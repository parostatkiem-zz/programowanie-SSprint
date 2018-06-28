using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint
{
    partial class Model
    {
        private Exception threadOverloaded = new Exception("Zbyt wiele wątków próbuje się połączyć z bazą!");

        SSprintEntities SSprintDataBase;

        public SSprintEntities GetBase() // pobiera referencję do bazy danych, na której możemy wykonywać zapytania
        {
            try
            {
                if (this.SSprintDataBase != null)
                    throw threadOverloaded;
                else
                {
                    this.SSprintDataBase = new SSprintEntities();
                    return SSprintDataBase;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }
        public void SaveChanges(SSprintEntities data) // zapisuje zmiany do bazy danych
        {
            try
            {
                data.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.FinalizeBase();
            }
        }   

        public void FinalizeBase() // zamyka połączenie z bazą
        {
            SSprintDataBase = null;
        }
    }
}
