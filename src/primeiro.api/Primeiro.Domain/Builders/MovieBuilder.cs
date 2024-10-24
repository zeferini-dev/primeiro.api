using Bogus;
using Infra.Data.Domain;
using NetCore.Base.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Primeiro.Domain.Builders
{
    public class MovieBuilder
    {
        private string _id;
        private EStatus _status;
        private DateTime _insertedOn;
        private string _insertedBy;
        private string _updatedBy;
        private DateTime _updatedOn;

        private string _title;
        private string _genre;
        private string _name;
        private int _year;

        private Movie _movie;

        private static Faker _faker = new Faker();

        public MovieBuilder WithInsertedOn(DateTime insertedOn)
        {
            _insertedOn = insertedOn;
            return this;
        }

        public MovieBuilder WithUpdatedOn(DateTime updatedOn)
        {
            _updatedOn = updatedOn;
            return this;
        }

        public MovieBuilder WithId(string id)
        {
            _id = id;
            return this;
        }

        public MovieBuilder WithStatus(EStatus status)
        {
            _status = status;
            return this;
        }

        public MovieBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }

        public MovieBuilder WithName(string name)
        {
            try
            {
                _name = name;
                return this;
            }
            catch (Exception ex)
            {
                string sex = ex.Message;
                throw;
            }

        }

        public MovieBuilder WithGenre(string genre)
        {
            _genre = genre;
            return this;
        }

        public MovieBuilder WithYear(int year)
        {
            _year = year;
            return this;
        }

        public MovieBuilder WithInsertedBy(string insertedBy)
        {
            _insertedBy = insertedBy;
            return this;
        }
        public MovieBuilder WithUpdatedBy(string updatedBy)
        {
            _updatedBy = updatedBy;
            return this;
        }

        public MovieBuilder()
        {
            var eStatus = new EStatus[] { EStatus.ATIVO, EStatus.INATIVO, EStatus.EXCLUIDO };

            _id = Guid.NewGuid().ToString();
            _title = _faker.Lorem.Sentence(3);
            _genre = _faker.Lorem.Sentence(3);
            _name = _faker.Lorem.Sentence(3);
            _year = 2024;
            _status = _faker.PickRandom(eStatus);
            _insertedBy = Guid.NewGuid().ToString();
            _insertedOn = DateTime.Now;
            _updatedBy = Guid.NewGuid().ToString();
            _updatedOn = DateTime.Now;

         }

        public Movie Build()
        {
            _movie  = new Movie(
                _id, _name, _title, _genre
                , _year, _status, _insertedBy
                , _insertedOn, _updatedBy, _updatedOn);
            return _movie;
        }
    }
}
