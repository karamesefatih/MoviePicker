using Business.Abstract;
using Business.ResponseMessages;
using Core.Concrete;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class MoviesManager : IMoviesService
    {
        IMovieDal _moviesDal;

        public MoviesManager(IMovieDal moviesDal)
        {
            _moviesDal = moviesDal;
        }

        public IResult Add(Movie movies)
        {
            _moviesDal.Add(movies);
            return new SuccessResult(Messages.MovieAdded);
        }

        public IResult Delete(Movie movies)
        {
            _moviesDal.Delete(movies); return new SuccessResult(Messages.MovieDeleted);
        }

        public IDataResult<List<Movie>> GetAll()
        {
            return new SuccessDataResult<List<Movie>>(_moviesDal.GetList(),Messages.MoviesListed);
        }

        public IDataResult<List<Movie>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Movie>>(_moviesDal.GetList(x=>x.CategoryId == categoryId),Messages.MoviesListedByCategory);
        }

        public IDataResult<List<Movie>> GetByImdb(int iMdbId)
        {
            return new SuccessDataResult<List<Movie>>(_moviesDal.GetList(x => x.IMDb == iMdbId),Messages.MoviesListedByImdb);
        }

        public IResult Update(Movie movies)
        {
            _moviesDal.Update(movies);
            return new SuccessResult(Messages.MovieUpdated);
        }
    }
}
