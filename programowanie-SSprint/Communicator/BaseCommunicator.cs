using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint.Communicator
{
    abstract class BaseCommunicator<elementType> where elementType : CommunicatorElement<elementType>
    {
        protected static SSprintContext dataBase;
        protected static readonly Exception threadConflict;
        protected static readonly Exception badDataType;
        protected static readonly Exception connectionFailure;
        protected static readonly Exception savingFailure;
        protected static readonly Exception badBaseConfiguration;
        protected static readonly Exception findingFailure;
        protected static readonly Exception nullReference;

        static BaseCommunicator()
        {
            threadConflict = new Exception("Zbyt wiele operacji wykonywanych na jednej bazie!");
            threadConflict.HelpLink = "Błąd wynika z powodu źle zaprojektowanej obsługi tego zdarzenia. Skontaktuj się z pomocą techniczną i przekaż informacje o tym!";

            badDataType = new Exception("Zły format danych! Upewnij się, że wszystko zostało poprawnie wypełnione.");
            badDataType.HelpLink = "Upewnij się, że wszystkie dane posiadają odpowiedni typ i formatowanie.";

            connectionFailure = new Exception("Brak połączenia z bazą. Upewnij się, że jesteś podłączony z internetem i podałeś poprawne dane logowania do bazy.");
            connectionFailure.HelpLink = "Sprawdź swoje połączenie z internetem.\nUpewnij się, że plik z danymi logowania został wypełniony prawidłowo.";

            savingFailure = new Exception("Błąd zapisywania danych.");
            savingFailure.HelpLink = "Baza odmówiła zapisania zmian. \nUpewnij się, że pola NOT NULL nie zostały puste oraz baza nie uległa zmianie.";

            badBaseConfiguration = new Exception("Baza nie pozwoliła na wykonanie tej operacji.");
            badBaseConfiguration.HelpLink = "Upewnij się, że obiekt istnieje oraz masz do niego dostęp.";

            findingFailure = new Exception("Baza nie znalazła tego obiektu.");
            findingFailure.HelpLink = "Upewnij się, że wskazywany obiekt istnieje w bazie.";

            nullReference = new Exception("Do bazy nie został przesłany żaden obiekt.");
            nullReference.HelpLink = "Upewnij się, że wskazywany obiekt został wypełniony poprawnie";
        }
        ~BaseCommunicator()
        {
            dataBase = null;
        }

        protected virtual SSprintContext GetBase()
        {
            return dataBase;
        }

        public virtual void Connect()
        {
            try
            {
                if (dataBase == null)
                    dataBase = new SSprintContext();
                else
                    throw threadConflict;
            }
            catch
            {
                throw connectionFailure;
            }
        }

        public virtual void SaveChanges()
        {
            try
            {
                dataBase.SaveChanges();
            }
            catch
            {
                throw savingFailure;
            }
            finally
            {
                this.FinalizeBase();
            }
        }
        public virtual void FinalizeBase()
        {
            dataBase = null;
        }

        public abstract void Insert(elementType newElement);
        public abstract void InsertRange(List<elementType> newElements);
        public abstract void Remove(elementType elementToRemove);
        public abstract void Update(ref elementType sourceElement, elementType newElement);
        public abstract List<elementType> getEntireTable();
        public abstract elementType Find(int elementID);
    }
}
