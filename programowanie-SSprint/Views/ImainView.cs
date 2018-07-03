using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    interface ImainView
    {

         event Func<IErrorable, ICommunicative, List<order>> getAllOrders;
         event Func<IErrorable, ICommunicative, order, bool> insertOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, order, bool> removeOrder;
         event Func<IErrorable, ICommunicative, List<singleItemOrder>, bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. UWAGA: czesc z nich moze juz istnieć w bazie, wtedy robi się UPDATE. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<singleItemOrder>, bool> deleteListOfItems; //usuwa liste zamówionych koszulek

         event Func<IErrorable, ICommunicative, color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<color>> getAllColors; //zwraca listę wszystkich kolorów
         event Func<IErrorable, ICommunicative, color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

         event Func<IErrorable, ICommunicative, picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<picture>> getAllPictures; //zwraca listę wszystkich obrazow
         event Func<IErrorable, ICommunicative, picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

         event Func<IErrorable, ICommunicative, style, bool> insertStyle; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<style>> getAllStyles; //zwraca listę wszystkich obrazow
         event Func<IErrorable, ICommunicative, style, bool> removeStyle; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

         event Func<IErrorable, ICommunicative, company, bool> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<company>> getAllCompanies; //zwraca listę wszystkich kolorów
         event Func<IErrorable, ICommunicative, company, bool> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało

         event Func<IErrorable, ICommunicative, tshirt, bool> insertTshirt; //jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, ICommunicative, List<tshirt>> getAllTshirts; //zwraca listę wszystkich tshirt
         event Func<IErrorable, ICommunicative, tshirt, bool> removeTshirt; //usuwa tshirt. Istotne jest tylko tshirt.id. Zwraca bool czy się udało



    }
}
