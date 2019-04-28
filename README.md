# MuiNavigation
ModernUI Navigation with Prism 7

Basically, how to integrate Prism7 with ModernUI.  NavigationService turned out not to be necessary provided you a) remember to use prism:ViewModelLocator.AutoWireViewModel="True" and b) remember to RaisePropertyChanged on the bound items.



