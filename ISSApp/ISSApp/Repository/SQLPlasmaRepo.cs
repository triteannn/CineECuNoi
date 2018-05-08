using ISSApp.Domain;
using System.Collections.Generic;

namespace Repository
{
    /**
     * 
     */
    public class SQLPlasmaRepo : ISQLRepo<PSPlasma>
    {

        /**
         * 
         */
        public SQLPlasmaRepo()
        {
        }


        /**
         * @param psPlasma 
         * @return
         */
        public void Add(PSPlasma psPlasma)
        {
            // TODO implement here
        }

        /**
         * @param psPlasma 
         * @return
         */
        public PSPlasma Delete(PSPlasma psPlasma)
        {
            // TODO implement here
            return null;
        }

        /**
         * @param psPlasma 
         * @return
         */
        public PSPlasma Update(PSPlasma psPlasma)
        {
            // TODO implement here
            return null;
        }

        /**
         * @param id 
         * @return
         */
        public PSPlasma FindEntity(int id)
        {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public List<PSPlasma> FindAll()
        {
            // TODO implement here
            return null;
        }

        /**
         * @param target 
         * @return
         */
        public List<PSPlasma> FindByTarget(string target)
        {
            // TODO implement here
            return null;
        }

    }
}