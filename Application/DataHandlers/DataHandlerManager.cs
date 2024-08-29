using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DataHandlers
{
    public class DataHandlerManager
    {
        private static IMasterDataHandler? _masterDataHandler;
        public static IMasterDataHandler GetMasterDataHandler() 
        { 
            if (_masterDataHandler == null)
            {
                _masterDataHandler = new MasterDataHandler();
            }
            return _masterDataHandler;

        }
    }
}
