using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Nnlib.RNNnlib
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNnlibModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNnlibModule"/>.
        /// </summary>
        internal RNNnlibModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNnlib";
            }
        }
    }
}
