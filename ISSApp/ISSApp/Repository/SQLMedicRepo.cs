using ISSApp.Domain;
using System.Collections.Generic;

namespace Repository
{
    /**
     * 
     */
    public class SQLMedicRepo : ISQLRepo<Medic>
    {

        /**
         * 
         */
        public SQLMedicRepo() { }

        /**
         * @param medic 
         * @return
         */
        public void Add(Medic medic)
        {
            // TODO implement here
        }

        /**
         * @param medic 
         * @return
         */
        public Medic Delete(Medic medic)
        {
            // TODO implement here
            return null;
        }

        /**
         * @param medic 
         * @return
         */
        public Medic Update(Medic medic)
        {
            // TODO implement here
            return null;
        }

        /**
         * @param id 
         * @return
         */
        public Medic FindEntity(Medic entity)
        {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public List<Medic> FindAll()
        {
            // TODO implement here
            return null;
        }

    }
}