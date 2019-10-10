using Dapper;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLCafe.DAL
{
    public class TableCoffeesRepository : BaseRepository, ITableCoffeesRepository
    {
        public bool TableCoffeesAdd(TableCoffeesAdd Requets)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AreaID", Requets.AreaID);
                parameters.Add("@Name", Requets.Name);

                SqlMapper.Execute(con, "TableCoffees_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TableCoffeesAddByID(TableCoffeesAddByID Requets)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AreaID", Requets.AreaID);
                parameters.Add("@Name", Requets.Name);

                SqlMapper.Execute(con, "TableCoffees_AddByID", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TableCoffeesDelete(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            SqlMapper.Execute(con, "TableCoffees_Delete", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<TableCoffees> TableCoffeesGetAll()
        {
            IList<TableCoffees> tableCoffeesGetAll = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return tableCoffeesGetAll;
        }

        public IList<TableCoffees> TableCoffeesGetBookedATable()
        {
            IList<TableCoffees> tableCoffeesGetBookedATable = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetBookedATable", commandType: CommandType.StoredProcedure).ToList();
            return tableCoffeesGetBookedATable;
        }

        public TableCoffees TableCoffeesGetByID(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            TableCoffees tableCoffeesGetByID = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return tableCoffeesGetByID;
        }

        public IList<TableCoffees> TableCoffeesGetByIdArea(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            IList<TableCoffees> tableCoffeesGetByIdArea = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetByIdArea", parameters, commandType: CommandType.StoredProcedure).ToList();
            return tableCoffeesGetByIdArea;
        }

        public IList<TableCoffees> TableCoffeesGetEmptyTable()
        {
            IList<TableCoffees> tableCoffeesGetEmptyTable = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetEmptyTable", commandType: CommandType.StoredProcedure).ToList();
            return tableCoffeesGetEmptyTable;
        }

        public IList<TableCoffees> TableCoffeesGetNotEmptyTable()
        {
            IList<TableCoffees> tableCoffeesGetNotEmptyTable = SqlMapper.Query<TableCoffees>(con, "TableCoffees_GetNotEmptyTable", commandType: CommandType.StoredProcedure).ToList();
            return tableCoffeesGetNotEmptyTable;
        }

        public bool TableCoffeesTobook(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            SqlMapper.Execute(con, "TableCoffees_Tobook", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool TableCoffeesToCanBook(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            SqlMapper.Execute(con, "TableCoffees_ToCanBook", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool TableCoffeesUpdate(TableCoffeesUpdate Requets)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Requets.Id);
                parameters.Add("@AreaID", Requets.AreaID);
                parameters.Add("@Name", Requets.Name);
                parameters.Add("@Status", Requets.Status);                

                SqlMapper.Execute(con, "TableCoffees_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
