
#import "RNReactNativeBeeper.h"
#import <AudioToolbox/AudioToolbox.h>

@implementation RNReactNativeBeeper

RCT_EXPORT_MODULE();

RCT_EXPORT_METHOD(beep)
{
  AudioServicesPlaySystemSound(1103);
}

@end
  
