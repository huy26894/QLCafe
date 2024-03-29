﻿using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL.Interface
{
    public interface ITableCoffeesService
    {
        IList<TableCoffees> TableCoffeesGetAll();
        TableCoffees TableCoffeesGetByID(int Id);
        bool TableCoffeesAdd(TableCoffeesAdd Requets);
        bool TableCoffeesUpdate(TableCoffeesUpdate Requets);
        bool TableCoffeesAddByID(TableCoffeesAddByID Requets);
        bool TableCoffeesDelete(int Id);
        IList<TableCoffees> TableCoffeesGetBookedATable();
        IList<TableCoffees> TableCoffeesGetByIdArea(int Id);
        IList<TableCoffees> TableCoffeesGetEmptyTable();
        IList<TableCoffees> TableCoffeesGetNotEmptyTable();
        bool TableCoffeesTobook(int Id);
        bool TableCoffeesToCanBook(int Id);
    }
}
