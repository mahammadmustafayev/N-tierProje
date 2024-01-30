using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class PortfolioManager : IPortfolioService
{
    private readonly IPortfolio _portfolio;

    public PortfolioManager(IPortfolio portfolio)
    {
        _portfolio = portfolio;
    }

    public List<Portfolio> GetList()
    {
        return _portfolio.GetList();
    }

    public void TAdd(Portfolio entity)
    {
        _portfolio.Insert(entity);
    }

    public void TDelete(Portfolio entity)
    {
        _portfolio.Delete(entity);
    }

    public Portfolio TGetById(int id)
    {
        return _portfolio.GetById(id);
    }

    public void TUpdate(Portfolio entity)
    {
        _portfolio.Update(entity);
    }
}
