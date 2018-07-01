using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    interface ImainView
    {

         event Action saveDatabaseToRemote; //zapisuje dane do bazy zdalnej

         //event Func<IErrorable, List<company>> getAllCompany; // pobiera wszystkie dane z tabeli company

        // event Func<IErrorable, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
         event Func<IErrorable, int, order> getSingleOrder; //pobiera jeden order o danym ID

         event Func<IErrorable, order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<singleItemOrder>, bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało


         event Func<IErrorable, color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
         event Func<IErrorable, color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

         event Func<IErrorable, picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<picture>> getAllPictures; //zwraca listę wszystkich obrazow
         event Func<IErrorable, picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

         event Func<IErrorable, style, bool> insertStyle; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<style>> getAllStyles; //zwraca listę wszystkich obrazow
         event Func<IErrorable, style, bool> removeStyle; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

         event Func<IErrorable, company, bool> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<company>> getAllCompanies; //zwraca listę wszystkich kolorów
         event Func<IErrorable, company, bool> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało

         event Func<IErrorable, tshirt, bool> insertTshirt; //jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
         event Func<IErrorable, List<tshirt>> getAllTshirts; //zwraca listę wszystkich tshirt
         event Func<IErrorable, tshirt, bool> removeTshirt; //usuwa tshirt. Istotne jest tylko tshirt.id. Zwraca bool czy się udało



    }
}
