using OpenQA.Selenium;
using Task3._1.Main;
using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Test.PO
{
    class ElementsPage

    {   
        private Button webTables = new Button(By.XPath("//span[contains(text(),'Web Tables')]"),"Web Tables Form");
        private Page webTablesPage = new Page(By.XPath("//div[@class='main-header' and contains(text(),'Web Tables')]"), "Web Tables Page");
        private Button addButton = new Button(By.Id("addNewRecordButton"), "Add Button");
        private Label registForm = new Label(By.Id("registration-form-modal"), "Registration Form Label");
        private TextBox firstNameBox = new TextBox(By.Id("firstName"), "First Name Box");
        private TextBox lastNameBox = new TextBox(By.Id("lastName"), "Last Name Box");
        private TextBox emailNameBox = new TextBox(By.Id("userEmail"), "Email Name Box");
        private TextBox salaryBox = new TextBox(By.Id("salary"), "Salary Name Box");
        private TextBox ageBox = new TextBox(By.Id("age"), "Age Name Box");
        private TextBox departmentBox = new TextBox(By.Id("department"), "Department Name Box");
        private Button submitButton = new Button(By.Id("submit"), "Submit Button");
        private Button deleteButton = new Button(By.Id("delete-record-4"), "Delete Button");

        public void ClickWebTables()
        {
            webTables.click();
        }

        public bool isWebTableFormOpen()
        {
            return webTablesPage.isPageOpened();  
        }

        public void ClickAddButton()
        {
            addButton.click();
        }

        public bool isRegistFormOpen()
        {
            return registForm.isDisplayed();
        }

        public void ClickSubmitButton()
        {
            submitButton.click();
        }

        public bool isRegistFormStillOpen()
        {
            return modalContent.isDisplayed();
        }

        public void ClickDeleteButton()
        {
            deleteButton.click();
        }
        public void introduceTestData(int testDataIndex)
        {
            firstNameBox.type(jsonReader.getFirstName(testDataIndex));
            lastNameBox.type(jsonReader.getLastName(testDataIndex));
            emailNameBox.type(jsonReader.getEmail(testDataIndex));
            ageBox.type(jsonReader.getAge(testDataIndex));
            salaryBox.type(jsonReader.getSalary(testDataIndex));
            departmentBox.type(jsonReader.getDepartment(testDataIndex));
        }

        public Label modalContent = new Label(By.XPath("//div[@class='modal-content']"), "Modal Content");
        public Label usersTable = new Label(By.CssSelector(".rt-tbody"), "Users Table");

        public List<string> getFirstRowData()
        {
            IWebElement row = usersTable.getElement().FindElements(By.CssSelector(".rt-tr-group"))[3];
            IReadOnlyCollection<IWebElement> cellElements = row.FindElements(By.CssSelector(".rt-td:not(:last-child)"));
            List<string> textList = new List<string>();
            foreach (IWebElement cellElement in cellElements)
            {
                string text = cellElement.Text;
                textList.Add(text);
            }
            return textList;
        }

    }
}
