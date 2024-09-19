using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeaturService
    {
            private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal=featureDal;
        }
        public void TAdd(Feature entity)
        {
            _featureDal.Add(entity);

        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
           return _featureDal.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
        return _featureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);

        }

    }
}