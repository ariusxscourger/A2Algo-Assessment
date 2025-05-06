# A2Algo-Assessment
Scenario: Develop an inventory management system with Angular frontend, .NET 7 backend, and SQL Server database. The system should include products, sales, and purchases modules for comprehensive inventory control.

Requirements: Create a system with modules:
Products: Manage inventory with add, edit, and delete features.
Sales: Record transactions and update inventory. (Bonus point)
Purchases: Track orders and update inventory on receipt. (Bonus point)

Frontend: 
Utilize latest Angular for frontend. Create components to display products, add/edit products, delete products, record sales, and track purchases.

Backend: 
Develop backend using .NET 7. Set up CRUD operations for products. 
Create models for sales and purchases. Design APIs for recording sales and tracking purchases. (Bonus point)

Database: 
Assume SQL Server availability. Construct "Products" table with ID, name, description, and quantity. 
Create separate tables for "Sales" and "Purchases." (Bonus point)

Evaluation: 
Assess based on implementation, coding standards adherence, code quality, and user experience.

Submit the completed code for both frontend and backend, along with instructions for setup and execution, via a GitHub repository link.

### 📝 **How to Launch the Inventory Management System**

#### **1. Backend (ASP.NET 7) Setup**

1. **Prerequisites**:

   * Ensure that you have **.NET 7** installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet/7.0).
   * Make sure you have **SQL Server LocalDB** installed. It comes with Visual Studio or can be installed separately.

2. **Clone or Download the Repository**:

   * Clone the repository or download the code to your local machine.

3. **Navigate to the Backend Folder**:
   Open a terminal/command prompt and navigate to the directory where your backend project is located.

4. **Restore NuGet Packages**:
   Run the following command to restore the required NuGet packages:

   ```bash
   dotnet restore
   ```

5. **Configure the Database**:
   Ensure that **`appsettings.json`** is correctly configured with your database connection string. For LocalDB:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=InventoryDb;Trusted_Connection=True;"
   }
   ```

6. **Apply Migrations**:
   Run the following commands to create the database schema:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

7. **Start the Backend**:
   You can start the backend by running the following command:

   ```bash
   dotnet run
   ```

   The API should now be available at `https://localhost:5001`.

#### **2. Frontend (Angular) Setup**

1. **Prerequisites**:

   * Ensure that **Node.js** and **npm** are installed. You can download them from [here](https://nodejs.org/).

2. **Clone or Download the Repository**:

   * Clone the repository or download the code to your local machine.

3. **Navigate to the Frontend Folder**:
   Open a terminal and navigate to the Angular project folder.

4. **Install Dependencies**:
   Run the following command to install the required dependencies:

   ```bash
   npm install
   ```

5. **Configure the API URL**:
   Make sure that the API URL in `src/app/inventory.service.ts` is pointing to the correct backend address:

   ```typescript
   private apiUrl = 'https://localhost:5001/api'; // Adjust if needed
   ```

6. **Start the Angular Frontend**:
   Run the following command to start the Angular development server:

   ```bash
   ng serve
   ```

   The frontend will now be available at `http://localhost:4200`.

---

### 🧑‍💼 **Testing the Application**

* **Frontend**: Open a browser and navigate to `http://localhost:4200`. You should see the **inventory management system** interface.
* **Backend**: You can use **Postman** or **Swagger UI** (available by default in your backend project) to test API endpoints like `/api/products`, `/api/sales`, and `/api/purchases`.

---
