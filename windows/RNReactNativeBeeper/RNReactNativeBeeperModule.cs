using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Beeper.RNReactNativeBeeper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeBeeperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeBeeperModule"/>.
        /// </summary>
        internal RNReactNativeBeeperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeBeeper";
            }
        }
    }
}
