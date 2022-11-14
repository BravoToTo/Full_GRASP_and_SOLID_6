using System;

namespace Full_GRASP_And_SOLID;

public class Adapter : TimerClient
{
    private CountdownTimer T1 = new CountdownTimer();

    private Recipe recipe;

    public Adapter(Recipe R) {
        this.recipe = R;
    }

    public void SetTimer(int TimeOut) {
        T1.Register(TimeOut, this);
    }

    public void TimeOut() {
        this.recipe.SetCooked();
    }
}