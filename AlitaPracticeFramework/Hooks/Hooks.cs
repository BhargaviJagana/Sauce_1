using TechTalk.SpecFlow;

[Binding]
public class Hooks {
    [BeforeScenario]
    public void BeforeScenario() {
        // Code to run before each scenario
    }

    [AfterScenario]
    public void AfterScenario() {
        // Code to run after each scenario
    }
}