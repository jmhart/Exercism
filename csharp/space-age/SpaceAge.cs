public class SpaceAge
{
    private readonly double seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return this.seconds / OrbitalPeriod.Earth;
    }

    public double OnMercury()
    {
        return this.seconds / OrbitalPeriod.Mercury;
    }

    public double OnVenus()
    {
        return this.seconds / OrbitalPeriod.Venus;
    }

    public double OnMars()
    {
        return this.seconds / OrbitalPeriod.Mars;
    }

    public double OnJupiter()
    {
        return this.seconds / OrbitalPeriod.Jupiter;
    }

    public double OnSaturn()
    {
        return this.seconds / OrbitalPeriod.Saturn;
    }

    public double OnUranus()
    {
        return this.seconds / OrbitalPeriod.Uranus;
    }

    public double OnNeptune()
    {
        return this.seconds / OrbitalPeriod.Neptune;
    }
}

public struct OrbitalPeriod
{
    public const double Earth = 31557600;
    public const double Mercury = Earth * 0.2408467;
    public const double Venus = Earth * 0.61519726;
    public const double Mars = Earth * 1.8808158;
    public const double Jupiter = Earth * 11.862615;
    public const double Saturn = Earth * 29.447498;
    public const double Uranus = Earth * 84.016846;
    public const double Neptune = Earth * 164.79132;
}