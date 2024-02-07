using BussinesLayer.Services;
using DataLayer.Abstract;
using DataLayer.EntitiyFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class PortfolioManager : IGenericService<Portfolio>, IPortfolioService
{
    private readonly IPortfolio _portfolio;

    public PortfolioManager(IPortfolio portfolio)
    {
        _portfolio = portfolio;
    }



    public void TAdd(Portfolio t)
    {
        _portfolio.Add(t);
    }

    public List<Portfolio> TGetAll()
    {
       return _portfolio.GetAll();
    }

    public Portfolio TGetById(int id)
    {
        return (Portfolio)_portfolio.GetById(id);

    }

    public void TRemove(Portfolio t)
    {
        _portfolio.Delete(t);

    }

    public void TUpdate(Portfolio t)
    {
        _portfolio.Delete(t);
    }
}
