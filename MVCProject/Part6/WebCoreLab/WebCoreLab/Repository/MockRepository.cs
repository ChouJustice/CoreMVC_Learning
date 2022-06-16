using System.Collections.Generic;
using System.Linq;
using WebCoreLab.Mock;
using WebCoreLab.Models.DBEntity;

namespace WebCoreLab.Repository
{
    public class MockRepository
    {
        private readonly Dictionary<string, dynamic> _mockData;

        public MockRepository()
        {
            _mockData = MockData.DataList;
        }

        public void Create<T>(T entity) where T : DBEntity
        {
            var t = (List<T>)_mockData[typeof(T).Name];
            t.Add(entity);
        }

        public void Update<T>(T entity) where T : DBEntity
        {
            var t = (List<T>)_mockData[typeof(T).Name];
            t[t.FindIndex(x => x.Id == entity.Id)] = entity;
        }

        public void Delete<T>(T entity) where T : DBEntity
        {
            var t = (List<T>)_mockData[typeof(T).Name];
            t.Remove(entity);
        }

        public IQueryable<T> GetAll<T>() where T : DBEntity
        {
            var t = (List<T>)_mockData[typeof(T).Name];
            return t.AsQueryable();
        }

        public void Save() { }
    }
}
