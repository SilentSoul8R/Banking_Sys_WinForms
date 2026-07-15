# 🏦 Banking Management System — WinForms

> A desktop banking application built with **C# and Windows Forms (.NET)**, providing a simple graphical interface to create, deposit, withdraw, edit, remove, and display bank accounts, all backed by flat-file persistence.

---
<div align="center">

<img width="798" height="478" alt="image" src="https://github.com/user-attachments/assets/6fde567f-8d93-4463-812d-981c9ccbd510" />

</div>
---

## 📖 Overview

This project simulates the core operations of a retail bank through a lightweight WinForms desktop app. Users interact through a central menu (`Form1`) that launches dedicated forms for each banking operation. Account data is held in memory during runtime and persisted to a local text file (`AccFile.txt`) using comma-separated values.

---

## ✨ Features

| Feature | Description |
|---|---|
| 🆕 **Create Account** | Register a new account with a unique account number and starting balance (rejects negative balances) |
| 💵 **Deposit** ("Add Money") | Add funds to an existing account, with empty-field and negative-amount validation |
| 💸 **Withdrawal** ("Withdraw Money") | Remove funds from an account, with empty-field, negative-amount, and insufficient-funds protection |
| ✏️ **Edit Account** | Update an existing account's number/balance from the grid |
| 🗑️ **Remove Account** | Delete an account by its account number string (from the main menu or the grid) |
| 📋 **View All Accounts** | View every active account in a currency-formatted `DataGridView` with inline Edit/Delete buttons |
| 📊 **Live Dashboard Stats** | Main menu shows a running "X Users trust us" count and the bank's total balance on startup |
| 💾 **Save & Exit** | Persist all in-memory accounts to disk on exit |

---

## 🗂️ Project Structure

```
WinFormsBankingApp/
│
├── Program.cs                     # Application entry point
├── Form1.cs / .Designer.cs        # Main menu / dashboard (with live stats + app icon)
├── CreateAccountForm.cs / .Designer.cs  # Standalone account creation form
├── AddNewAccDisplay.cs / .Designer.cs   # Account creation form (launched from DisplayForm)
├── Deposit.cs / .Designer.cs      # Deposit funds form ("Add Money")
├── Withdrawal.cs / .Designer.cs   # Withdraw funds form ("Withdraw Money")
├── DisplayForm.cs / .Designer.cs  # View all accounts (DataGridView + inline Edit/Delete)
├── FormEditRecord.cs / .Designer.cs  # Edit an existing account's number/balance
├── Account.cs                     # Account model/entity
├── Banking.cs                     # Static business-logic / data-access layer
└── AccFile.txt                    # Flat-file data store (CSV: AccountNumber,Balance)
```

---

## 🧩 Architecture

### Class Diagram (conceptual)

```
┌───────────────┐        uses         ┌──────────────────┐
│    Form1      │────────────────────▶│      Banking      │
│ (Main Menu,   │                     │  (static logic +   │
│  live stats)  │                     │  UI messageboxes)  │
└───────┬───────┘                     └─────────┬──────────┘
        │ opens                                 │ manages
        ▼                                        ▼
┌────────────────────────────┐          ┌───────────────┐
│ CreateAccountForm           │          │    Account     │
│ Deposit                     │          │  (model)       │
│ Withdrawal                  │          └───────────────┘
│ DisplayForm ──▶ AddNewAccDisplay        Numbera, Balance
│      └────────▶ FormEditRecord
└────────────────────────────┘
```

### 🔑 Key Classes

#### `Account`
A simple data model representing a bank account.

- `Numbera`, account number (`string`)
- `Balance`, current balance (`int`)
- `Convert_To_Str()`, `GetBalance()`, `GetNumber()`, helper accessors

#### `Banking` (static class)
The application's data-access and business-logic layer. Holds the in-memory `List<Account> accounts` and now handles both the logic **and** the user-facing success/error `MessageBox` popups for most operations:

- `Create(string, int)`, adds a new account, guards against duplicates **and negative balances**, appends to file, shows a confirmation popup, then saves
- `Deposit(string, int)`, increases balance for a matched account, shows a confirmation popup, then saves
- `Withdrawal(string, int)`, decreases balance if funds are sufficient (shows an "insufficient funds" popup instead of throwing if not), shows a confirmation popup on success, then saves
- `Remove(string)`, deletes an account by matching its account-number string (see ⚠️ note below)
- `DisplayAll()`, returns account summaries as strings
- `ExitWithSave()`, writes all accounts back to `AccFile.txt`
- `LoadAccounts()` / `LoadAccountsIntoList()`, reads accounts from disk on startup

> Note: account **editing** (via `FormEditRecord`) still doesn't go through a dedicated `Banking` method — it mutates `Banking.accounts` directly (`Banking.accounts[Index].Balance = ...`) and then calls `ExitWithSave()`.

#### Forms
| Form | Purpose |
|---|---|
| `Form1` | Main dashboard; on construction, loads accounts and computes/displays a live user count and total bank balance |
| `CreateAccountForm` | Collects account number + balance, calls `Banking.Create`, then also explicitly calls `Banking.ExitWithSave()` again |
| `AddNewAccDisplay` | A secondary "add account" dialog launched from `DisplayForm`, ⚠️ currently non-functional, see limitations |
| `Deposit` | Validates input, then calls `Banking.Deposit` (which now owns the success popup) |
| `Withdrawal` | Validates input, then calls `Banking.Withdrawal` (which now owns the success/failure popups) |
| `DisplayForm` | Shows all accounts in a currency-formatted `DataGridView` with **Edit**/**Delete** button columns and an "Add New" button |
| `FormEditRecord` | Looks up an account by number and overwrites its number/balance, then saves |

---

## 💾 Data Persistence

Accounts are stored as plain CSV lines in a local text file (`AccFile.txt`). Current sample data:

```
acc1,16976
acc2,150
acc3,7050
acc4,2500
acc5,140
acc7,1875
acc9,1250
acc11,8650
acc12,1000
acc13,2455
acc14,500
acc15,750
acc16,0
acc18,0
```

The file path is currently **hardcoded** to a developer machine:

```csharp
static String Acc_File_Path = @"************\WinFormsBankingApp\WinFormsBankingApp\AccFile.txt";
```

> ⚠️ **Note:** This path must be updated (ideally to a relative or `Application.StartupPath`-based path) before running on another machine.

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- [.NET SDK](https://dotnet.microsoft.com/) (Windows Forms support, `net6.0-windows` or later)
- Visual Studio 2022 (recommended) or `dotnet` CLI

### Run the App

```bash
git clone <your-repo-url>
cd WinFormsBankingApp
dotnet build
dotnet run
```

Or simply open the `.sln` file in Visual Studio and press **F5**.

### First-Time Setup
1. Update `Acc_File_Path` in `Banking.cs` to a valid path on your machine.
2. Ensure the target directory exists (or let `Banking.LoadAccounts()` create the file automatically).
3. Launch the app, the main menu appears showing live account stats and navigation buttons.

---

## 🧭 User Flow

```
Form1 (Main Menu — shows live "X Users trust us" + total balance on load)
 ├── Create Account      → CreateAccountForm → Banking.Create() → ExitWithSave() (called twice)
 ├── Remove Account       → InputBox (string acc number, validated non-empty) → Banking.Remove()
 ├── View All Accounts    → DisplayForm → DataGridView (currency-formatted Balance column)
 │                           ├── Add New   → AddNewAccDisplay → ⚠️ shows success label but never creates the account
 │                           ├── "Edit" column button   → FormEditRecord → mutates Banking.accounts → ExitWithSave()
 │                           └── "Delete" column button → InputBox → Banking.Remove()
 ├── Add Money (Deposit)      → Deposit → validate → Banking.Deposit() (popup + save inside Banking)
 ├── Withdraw Money            → Withdrawal → validate → Banking.Withdrawal() (popup + save inside Banking)
 └── Exit and Save        → Banking.ExitWithSave()
```

---

## ⚠️ Known Limitations

- 🔒 **Hardcoded file path**: not portable across machines out of the box
- 🐛 **`AddNewAccDisplay` is currently broken**: `btnCreateAccYesDisplay_Click` sets `lblMessage.Text` to a success message and then hits an unconditional `return`, so the actual `Banking.Create(...)` call (and its validation/try-catch) below is dead code and never runs. Clicking "Add Account" from `DisplayForm` currently creates nothing.
- 🧟 **Leftover scratch code**: `AddNewAccDisplay.cs` contains an unrelated `Person` class with a `SayHello` method that appears to be test/example code left in the file.
- 🔁 **`Banking.Remove` mutates a list while iterating it**: the `foreach (var x in accounts) { ... accounts.Remove(x); }` pattern is the exact scenario that throws `InvalidOperationException: Collection was modified` in .NET; it may appear to "work" only because the loop exits right after the match, but it's fragile and not guaranteed safe.
- 🎭 **Layered responsibilities**: `Banking.Deposit`/`Withdrawal`/`Create` now show their own `MessageBox` popups and call `ExitWithSave()` internally, in addition to forms doing their own validation/popups. This mixes business logic with UI concerns and creates some redundant saves (e.g. `CreateAccountForm` calls `ExitWithSave()` again right after `Banking.Create()` already did).
- 🖱️ **Grid "Edit"/"Delete" buttons don't target the clicked row**: clicking either button opens an `InputBox`/`FormEditRecord` that asks the user to re-type the account number rather than acting on the row that was clicked.
- ✏️ **`FormEditRecord` has no pre-fill**: the form doesn't load the selected account's current number/balance into its text boxes, so the user must know and re-type the exact existing account number to edit it.
- 🧵 **No concurrency/locking** protection for simultaneous file access.
- 🧮 **Balance validation is inconsistent**: `Create` and the `Deposit`/`Withdrawal` forms all check for negative amounts independently, with no shared validation helper.

---

## 🛠️ Suggested Improvements

-  Replace hardcoded path with `Path.Combine(Application.StartupPath, "AccFile.txt")`
-  Fix `AddNewAccDisplay.btnCreateAccYesDisplay_Click`, remove the early `return` (or make it conditional) so account creation actually executes
-  Remove the stray `Person`/`SayHello` scratch class from `AddNewAccDisplay.cs`
-  Rewrite `Banking.Remove` using a reverse `for` loop, `RemoveAll(predicate)`, or `.ToList()` snapshot to avoid mutate-while-iterating
-  Decide on one layer for user feedback (either `Banking` or the forms, not both) to avoid duplicate saves/popups
-  Pass the clicked row's account data into `FormEditRecord`/delete flow instead of re-prompting via `InputBox`
-  Pre-fill `FormEditRecord`'s text boxes with the selected account's current values
-  Extract a shared `IsValidAmount(int)` helper instead of repeating negative-number checks
-  Move to a real data store (SQLite/JSON) instead of raw CSV text
-  Introduce unit tests for `Banking` logic, decoupled from `MessageBox`/UI calls

---

## 📜 License

This project is provided as-is for educational purposes. Add your preferred license here.

---

<div align="center">

**Built with ❤️ using C# WinForms**

</div>
