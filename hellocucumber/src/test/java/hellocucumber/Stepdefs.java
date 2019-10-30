package hellocucumber;

import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import org.openqa.selenium.chrome.ChromeDriver;

import static org.junit.Assert.*;

public class Stepdefs {

    @Given("today is Sunday")
    public void today_is_Sunday() {
        System.out.println("Do something");
        ChromeDriver driver = new ChromeDriver();
        String baseUrl = "https://www.google.com/gmail";
        driver.get(baseUrl);
        //throw new cucumber.api.PendingException();
    }

}
