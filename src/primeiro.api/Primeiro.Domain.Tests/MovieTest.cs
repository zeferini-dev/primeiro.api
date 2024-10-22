using Bogus;
using NetCore.Base;
using Primeiro.Domain.Builders;

namespace Primeiro.Domain.Tests
{
    public class MovieTest
    {
        private readonly Faker _faker;

        public MovieTest()
        {
            _faker = new Faker();
        }        

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Movie_Should_Not_Be_Created_With_Invalid_Id(string id)
        {
            Assert.Throws<BaseException>(() => new MovieBuilder().WithId(id).Build())
                  .WithMessage(Resources.Common.IdIsRequired);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]        
        public void Movie_Should_Not_Be_Created_With_Invalid_Title(string title)
        {
            Assert.Throws<BaseException>(() => new MovieBuilder().WithTitle(title).Build())
                  .WithMessage(Primeiro.Domain.Resources.Movie.TitleIsRequired);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Movie_Should_Not_Be_Created_With_Invalid_Name(string name)
        {
            Assert.Throws<BaseException>(() => new MovieBuilder().WithTitle(name).Build())
                  .WithMessage(Primeiro.Domain.Resources.Movie.TitleIsRequired);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Movie_Should_Not_Be_Created_With_Invalid_Genre(string genre)
        {
            Assert.Throws<BaseException>(() => new MovieBuilder().WithTitle(genre).Build())
                  .WithMessage(Primeiro.Domain.Resources.Movie.TitleIsRequired);
        }

       
    }
}