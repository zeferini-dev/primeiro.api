using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCore.Base;
using NetCore.Base.Enum;

namespace Infra.Data.Domain
{
    public sealed class Movie : Root
    {
        fsdfsd
        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }

        /// <summary>
        /// Get a new instance of Movie
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="year"></param>
        /// <param name="status"></param>
        /// <param name="insertedBy"></param>
        /// <param name="insertedOn"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updatedOn"></param>
        public Movie(string id, string name, string title, string genre, int year, EStatus status, string insertedBy, DateTime insertedOn, string updatedBy, DateTime? updatedOn) : base(name, status, insertedOn, insertedBy, updatedOn, updatedBy)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
            Validate();
        }

        /// <summary>
        /// Get an instance for Insert
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="year"></param>
        /// <param name="insertedBy"></param>
        public Movie(string name, string title, string genre, int year, string insertedBy)
            : base(name, insertedBy)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Genre = genre;
            Year = year;
            Validate();
        }

        /// <summary>
        /// Get an instance for Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="year"></param>
        /// <param name="status"></param>
        /// <param name="updatedBy"></param>
        public void Update(string id, string name, string title, string genre, int year, EStatus status, string updatedBy)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
            SetName(name, updatedBy);
            SetStatus(status, updatedBy);
            Validate();
        }

        private void Validate()
        {
            NetCore.Base.RuleValidator
                .New()
                .When(!ValidateGuid(Id), NetCore.Base.Resource.RootResource.IdIsRequired)
                .When(!ValidateString(Title, null, null), Primeiro.Domain.Resources.Movie.TitleIsRequired)
                .When(!ValidateString(Genre, null, null), Primeiro.Domain.Resources.Movie.GenreIsRequired)
                .When(!NetCore.Base.NumberValidator.ValidateInt(Year), Primeiro.Domain.Resources.Movie.YearIsRequired)
                .ThrowExceptionIfExists();
        }
    }
}
