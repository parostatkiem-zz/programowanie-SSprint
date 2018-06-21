using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    interface ImainView
    {
         event Func<IErrorable, List<DB_classes.Tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
         event Func<IErrorable, int, DB_classes.Order> getSingleOrder; //pobiera jeden order o danym ID

         event Func<IErrorable, DB_classes.Order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<DB_classes.SingleItemOrder>, bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało

    }
}
