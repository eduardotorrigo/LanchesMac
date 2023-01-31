using System.Diagnostics;
using LanchesMac.Infra.Repositories.Interface;
using LanchesMac.Models;
using LanchesMac.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LanchesMac.Controllers;

public class LanchesController : Controller
{
    private readonly ILancheRepository _lanchesRepository;

    public LanchesController(ILancheRepository LancheRepository)
    {
        _lanchesRepository = LancheRepository;
    }
    public IActionResult List(string categoria)
    {
        IEnumerable<Lanche> lanches;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(categoria))
        {
            lanches = _lanchesRepository.Lanches.OrderBy(l => l.LancheId);
            categoriaAtual = "Todos os lanches";
        }
        else
        {
            lanches = _lanchesRepository.Lanches.Where(c => c.Categoria.Nome.Equals(categoria)).OrderBy(l => l.Nome);
            categoriaAtual = categoria;

        }

        var lancheListViewModel = new LancheListViewModel
        {
            Lanches = lanches,
            CategoriaAtual = categoriaAtual
        };

        return View(lancheListViewModel);
    }
    public IActionResult Details(int lancheId)
    {
        var lanche = _lanchesRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        return View(lanche);
    }
    public IActionResult Search(string searchString)
    {
        IEnumerable<Lanche> lanches;
        string categoriaAtual = string.Empty;

        if(string.IsNullOrEmpty(searchString))
        {
            lanches = _lanchesRepository.Lanches.OrderBy(p => p.LancheId);
            categoriaAtual = "Todos os Lanches";
        }
        else
        {
            lanches = _lanchesRepository.Lanches.Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));
            if (lanches.Any())
                categoriaAtual = "Lanches";
                else
                categoriaAtual = "Nenhum lanche foi encontrado";
        }
        return View("~/Views/Lanches/List.cshtml", new LancheListViewModel
        {
            Lanches = lanches,
            CategoriaAtual = categoriaAtual
        });
    }

}
