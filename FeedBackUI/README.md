# FeedBackForm

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 14.2.3.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.
# FeedBacKForm

---------------------------------------------------------------------------------------------------------------------------
# Added by Vandana #

# Versions
Angular: 14.2.4
dotnet 6.0

# Backend Configurations
Configured the port number in https-provider-service.ts
Added Db coloum entities  in preview.components.ts
Enabled Cros origin in dotnet code 

# Angular Materials used
Using a common style.css file by adding configurations gobally 
Used angular material , steppers material , mat-dialog box



# Frontend  Understanding 

1) Created app route module for routing between modules
2) Created seperate modules - feedback , Mat , dailog-custom. 
In feedback.module I have multiple components embedded  - 
FeedbackformComponent : This Component has the summary of all the screen views
PersonalDetailsComponent: This component contains the first screen personal details (name , email , phonenumber)
QuestionComponent :This component holds all the relevent questions as per the task 
Used Stepper materials for capturing questions stepwise  in the UI
PreviewComponent : This is summary component where we have the summary of all the inputs keyed in previous screens.
------ Contains view for the  questionaries 
In mat.module have created to have angular material modules. 
-------  Angular material used 
In dailog-custom.module  has embedded component  ConfirmationDialog,AlertDialogComponent
-------  It is for  adding the pop-up screen & alert  screen . 
3)Created service layers - https-provider & shared-service 
https-provider : for the invoking backend API's
Shared-service : for the dynamic values for topics

* Created testcases for Angular in PersonalDetailsComponent.spec.ts
--here it contains test cases for username , email id  and phone number 

# Backend Understanding 
commands:
dotnet run
dotnet test 
https://localhost:7000/swagger/index.html
--FeedBackFormAPI
Created controller layer - having http headers calls 
Craeted Interface and servicelayer - having the business logic in it for crud operations
Created model layer - to have DB columns
Created helper layer - To map to the dto  to entity 
Created DTO pojo class
Created Data layer - for database connectivity
Created Startup.cs-- for endpoint url , cross origin , swagger configurations.

--FeedbackFormAPI.Tests
Created Controller - written Get & Create methods 
Created Repository - contains the sample data for test execution. 






# Extra info 
Added the initial screen to capture the personal details of the candidate 
Validations for the username , email and phone-no has been handled
In each screen its mandatory to choose a option 
Back and next buttons for each Screen are activated so you can navigate to the previous screen if any feedback has to be changed 
Summary screen is been created to display the summary of responses captured by the candidate 
Dialog is added before saving the data .
Making a POST call to backend API while sending the json body in request 
Created a sepearate schema then table "feedback "in Postgres DB to save all the details 
Added DB configurations in dotnet code.
Sequential ID genertaion has been taken care  at the backend
Made swagger comfigurations to test the API's:https://localhost:7000/swagger/index.html



