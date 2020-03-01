using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamtom.Database.Dapper.Crud;
using static Tamtom.Database.Dapper.Crud.CrudModels;
using static Tamtom.Database.Dapper.Generic;

namespace Tamtom.Sales.Currency
{
    public class Currency : Crud, ICrud
    {
        public Currency() : base("Currency", "Sales") { }

        public async Task<CurrencyModel> UserCurrency(SelectSingleModelWithID model)
        {
            return await ExecuteStoredProcedureFirstOrDefaultAsync<SelectSingleModelWithID, CurrencyModel>("[Identity].APP_SP_SEL_CurrencyByUserID", model);
        }

        #region Not implemented method
        public Task<int> DeActive(CrudModels.PrimaryKeyID id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActive(CrudModels.PrimaryKeyGuid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActiveLanguage(CrudModels.DeActiveLanguageModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeActiveLanguage(CrudModels.DeActiveLanguageModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(CrudModels.PrimaryKeyID id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(CrudModels.PrimaryKeyGuid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLanguage(CrudModels.DeleteLanguageModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteLanguage(CrudModels.DeleteLanguageModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndReturnInsertedID<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReturnType>> Select<ReturnType>(CrudModels.SelectModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnType> SelectSingle<ReturnType>(CrudModels.SelectSingleModelWithID model)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnType> SelectSingle<ReturnType>(CrudModels.SelectSingleModelWithGuid model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update<InputType>(InputType model)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
