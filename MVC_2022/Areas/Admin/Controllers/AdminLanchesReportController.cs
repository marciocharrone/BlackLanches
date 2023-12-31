﻿using FastReport.Data;
using FastReport.Web;
using LanchesMac.Areas.Admin.FastReportUtils;
using LanchesMac.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
    
{
    [Area("Admin")]
    public class AdminLanchesReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnv;
        private readonly RelatorioLanchesServices _relatorioLanchesServices;

        public AdminLanchesReportController(IWebHostEnvironment webHostEnv, RelatorioLanchesServices relatorioLanchesServices)
        {
            _webHostEnv = webHostEnv;
            _relatorioLanchesServices = relatorioLanchesServices;
        }

        public async Task<ActionResult> LanchesCategoriaReport()
        {
            var webReport = new WebReport();
            var mssqlDataConnection = new MsSqlDataConnection();

            webReport.Report.Dictionary.AddChild(mssqlDataConnection);
            webReport.Report.Load(Path.Combine(_webHostEnv.ContentRootPath, "wwwroot/reports",
                                               "lanchesCategoria.frx"));
            var lanches = HelperFastReport.GetTable(await _relatorioLanchesServices.GetLanchesReport(), "LanchesReport");
            var categorias = HelperFastReport.GetTable(await _relatorioLanchesServices.GetCategoriasReport(), "CategoriasReport");

            webReport.Report.RegisterData(lanches, "LancheReport");
            webReport.Report.RegisterData(categorias, "CategoriasReport");
            return View(webReport);
        }
    }
}
