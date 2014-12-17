using AbstractCoffeeMaker;

namespace M4CoffeeMaker
{
    public class M4CoffeeMakerApi : CoffeeMakerAPI
    {
        WarmerPlateStatus warmerPlateStatus;
        BoilerStatus boilerStatus;
        BoilerState boilerState;
        BrewButtonStatus brewButtonStatus;
        WarmerState warmerState;
        IndicatorState indicatorState;
        ReliefValveState reliefValveState;

        public M4CoffeeMakerApi()
        {
            warmerPlateStatus = WarmerPlateStatus.WARMER_EMPTY;
            boilerStatus = BoilerStatus.EMPTY;
            boilerState = BoilerState.OFF;
            brewButtonStatus = BrewButtonStatus.NOT_PUSHED;
            warmerState = WarmerState.OFF;
            indicatorState = IndicatorState.OFF;
            reliefValveState = ReliefValveState.CLOSED;
        }

        public WarmerPlateStatus GetWarmerPlateStatus()
        {
            return warmerPlateStatus;
        }        


        /*Note on GetBoilerStatus
        * This function returns the status of the boiler switch.
        * The boiler switch is a float switch that detects if * there is more than 1/2 cup of water in the boiler.
        */
        public BoilerStatus GetBoilerStatus()
        {
            return boilerStatus;
        }
            

        /*Note on GetBrewButtonStatus
        * This function returns the status of the brew button.
        * The brew button is a momentary switch that remembers
        * its state. Each call to this function returns the
        * remembered state and then resets that state to
        * NOT_PUSHED.
        *
        * Thus, even if this function is polled at a very slow
        * rate, it will still detect when the brew button is
        * pushed.
        */
        public BrewButtonStatus GetBrewButtonStatus()
        {
            return brewButtonStatus;
        }
        
        
        
        
        /*
        * This function turns the heating element in the boiler
        * on or off.
        */
        public void SetBoilerState(BoilerState s)
        {
            boilerState = s;
        }
        
        
        
        
        /*
        * This function turns the heating element in the warmer
        * plate on or off.
        */
        public void SetWarmerState(WarmerState s)
        {
            warmerState = s;
        }
        
        
        
        /*
        * This function turns the indicator light on or off.
        * The indicator light should be turned on at the end
        * of the brewing cycle. It should be turned off when
        * the user presses the brew button.
        */
        public void SetIndicatorState(IndicatorState s)
        {
            indicatorState = s;
        }
        
        /*
        * This function opens and closes the pressure-relief
        * valve. When this valve is closed, steam pressure in
        * the boiler will force hot water to spray out over
        * the coffee filter. When the valve is open, the steam
        * in the boiler escapes into the environment, and the
        * water in the boiler will not spray out over the filter.
        */
        public void SetReliefValveState(ReliefValveState s)
        {
            reliefValveState = s;
        }
    }



    }
