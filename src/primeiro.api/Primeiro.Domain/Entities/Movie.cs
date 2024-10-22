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
        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }

_fakerfhfgh

        public Movie(string id, string name, string title, string genre, int year, EStatus status, string insertedBy, DateTime insertedOn, string updatedBy, DateTime? updatedOn) : base(name, status, insertedOn, insertedBy, updatedOn, updatedBy)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
        }

        public Movie(string id, string name, string title, string genre, int year, string insertedBy)
            : base(name, insertedBy)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
            Validate();
        }

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
