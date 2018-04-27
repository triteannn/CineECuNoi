using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace Repository{
    /**
     * 
     */
    public class SQLTrombociteRepo : ISQLRepo<PSTrombocite> {

        /**
         * 
         */
        public SQLTrombociteRepo() {}

        /**
         * @param psTrombocite 
         * @return
         */
        public void Add(PSTrombocite psTrombocite) {
            // TODO implement here
        }

        /**
         * @param psTrombocite 
         * @return
         */
        public PSTrombocite Delete(PSTrombocite psTrombocite) {
            // TODO implement here
            return null;
        }

        /**
         * @param psTrombocite 
         * @return
         */
        public PSTrombocite Update(PSTrombocite psTrombocite) {
            // TODO implement here
            return null;
        }

        /**
         * @param id 
         * @return
         */
        public PSTrombocite FindEntity(PSTrombocite entity) {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public List<PSTrombocite> FindAll() {
            // TODO implement here
            return null;
        }

        /**
         * @param target 
         * @return
         */
        public List<PSTrombocite> FindByTarget(string target) {
            // TODO implement here
            return null;
        }

    }
}