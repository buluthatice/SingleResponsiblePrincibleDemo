using SingleResponsiblePrincibleDemo;

StandartMessages.WelcomeMessage();

Person person = PersonDataCapture.Capture();

bool isPersonValid = PersonValidator.Validator(person);

if (!isPersonValid)
{
    StandartMessages.EndApplication();
    return;
}

//Create a username
AccountGenerator.Generator(person);

StandartMessages.EndApplication();