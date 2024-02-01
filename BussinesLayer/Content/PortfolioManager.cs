using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class PortfolioManager : IGenericService<Portfolio>, IPortfolioService
{
    private readonly IPortfolio _work;

    public PortfolioManager(IPortfolio portfolio)
    {
        _work = portfolio;
    }

    public void TAdd(Portfolio t)
    {
        throw new NotImplementedException();
    }

    public List<Portfolio> TGetAll()
    {
       return _work.GetAll();
    }

    public Portfolio TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public void TRemove(Portfolio t)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Portfolio t)
    {
        throw new NotImplementedException();
    }
}
