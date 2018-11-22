using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Screen.Layout.RNScreenLayout
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNScreenLayoutModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNScreenLayoutModule"/>.
        /// </summary>
        internal RNScreenLayoutModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNScreenLayout";
            }
        }
    }
}
