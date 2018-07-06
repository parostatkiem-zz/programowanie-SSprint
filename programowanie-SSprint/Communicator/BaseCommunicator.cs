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

        protected static readonly Exception threadConflictException;
        protected static readonly Exception badDataTypeException;
        protected static readonly Exception connectionException;
        protected static readonly Exception savingException;
        protected static readonly Exception badBaseConfigurationException;
        protected static readonly Exception findingException;
        protected static readonly Exception nullReferenceException;
        protected static readonly Exception operationException;

        static BaseCommunicator()
        {
            threadConflictException = new Exception("Zbyt wiele operacji wykonywanych na jednej bazie!");
            threadConflictException.HelpLink = "Błąd wynika z powodu źle zaprojektowanej obsługi tego zdarzenia. Skontaktuj się z pomocą techniczną i przekaż informacje o tym!";

            badDataTypeException = new Exception("Zły format danych! Upewnij się, że wszystko zostało poprawnie wypełnione.");
            badDataTypeException.HelpLink = "Upewnij się, że wszystkie dane posiadają odpowiedni typ i formatowanie.";

            connectionException = new Exception("Brak połączenia z bazą. Upewnij się, że jesteś podłączony z internetem i podałeś poprawne dane logowania do bazy.");
            connectionException.HelpLink = "Sprawdź swoje połączenie z internetem.\nUpewnij się, że plik z danymi logowania został wypełniony prawidłowo.";

            savingException = new Exception("Błąd zapisywania danych.");
            savingException.HelpLink = "Baza odmówiła zapisania zmian. \nUpewnij się, że pola NOT NULL nie zostały puste oraz baza nie uległa zmianie. \nUpewnij się, że masz prawa do edycji tego obiektu.";

            badBaseConfigurationException = new Exception("Baza nie pozwoliła na wykonanie tej operacji.");
            badBaseConfigurationException.HelpLink = "Upewnij się, że obiekt istnieje oraz masz do niego dostęp.";

            findingException = new Exception("Baza nie znalazła tego obiektu.");
            findingException.HelpLink = "Upewnij się, że wskazywany obiekt istnieje w bazie.";

            nullReferenceException = new Exception("Do bazy nie został przesłany żaden obiekt.");
            nullReferenceException.HelpLink = "Upewnij się, że wskazywany obiekt został wypełniony poprawnie";

            operationException = new Exception("Baza odmówiła operacji na tym obiekcie");
            operationException.HelpLink = "Upewnij się, że masz prawa do wykonania tej operacji";
        }
        ~BaseCommunicator()
        {
            dataBase = null;
        }

        public virtual SSprintContext GetBase()
        {
            return dataBase;
        }

        public virtual void NewConnection()
        {
            try
            {
                if (dataBase == null)
                    dataBase = new SSprintContext();
                else
                    throw threadConflictException;
            }
            catch
            {
                throw connectionException;
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
                throw savingException;
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
