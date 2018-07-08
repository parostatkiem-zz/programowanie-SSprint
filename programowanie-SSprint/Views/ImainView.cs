using System;
using System.Collections.Generic;

namespace programowanie_SSprint
{
    interface ImainView
    {

       event Action<IErrorable, ICommunicative> getAllOrders;
       event Action<IErrorable, ICommunicative, order> insertOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative, order> removeOrder;
       event Action<IErrorable, ICommunicative, List<singleItemOrder>> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. UWAGA: czesc z nich moze juz istnieć w bazie, wtedy robi się UPDATE. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative, List<singleItemOrder>> deleteListOfItems; //usuwa liste zamówionych koszulek

       event Action<IErrorable, ICommunicative, color> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative> getAllColors; //zwraca listę wszystkich kolorów
       event Action<IErrorable, ICommunicative, color> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

       event Action<IErrorable, ICommunicative, picture> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative> getAllPictures; //zwraca listę wszystkich obrazow
       event Action<IErrorable, ICommunicative, picture> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

       event Action<IErrorable, ICommunicative, style> insertStyle; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative> getAllStyles; //zwraca listę wszystkich obrazow
       event Action<IErrorable, ICommunicative, style> removeStyle; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

       event Action<IErrorable, ICommunicative, company> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative> getAllCompanies; //zwraca listę wszystkich kolorów
       event Action<IErrorable, ICommunicative, company> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało

       event Action<IErrorable, ICommunicative, tshirt> insertTshirt; //jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
       event Action<IErrorable, ICommunicative> getAllTshirts; //zwraca listę wszystkich tshirt
       event Action<IErrorable, ICommunicative, tshirt> removeTshirt; //usuwa tshirt. Istotne jest tylko tshirt.id. Zwraca bool czy się udało



    }
}
