# MuiNavigation
ModernUI Navigation with Prism 7

Basically, how to integrate Prism7 with ModernUI.  The name is misleading, I deleted the NavigationService because it turned out not to be necessary provided you a) remember to use prism:ViewModelLocator.AutoWireViewModel="True" and b) remember to RaisePropertyChanged on the bound items.



