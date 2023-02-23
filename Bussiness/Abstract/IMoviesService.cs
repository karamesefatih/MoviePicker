using Core.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IMoviesService 
    {
        IDataResult <List<Movie>> GetAll();
        IDataResult <List<Movie>> GetByCategoryId(int categoryId);
        IDataResult <List<Movie>> GetByImdb(int iMdbId);
        IResult Add(Movie movies);
        IResult Update(Movie movies);
        IResult Delete(Movie movies);
    }
}
