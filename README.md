# 🏦 Banking Management System  (WinForms + SQL Server)

> A desktop banking application built with **C# WinForms**, backed by **Microsoft SQL Server** (via `Microsoft.Data.SqlClient`), supporting account creation, deposits, withdrawals, editing, deletion, and multi-field filtered search.

---

<div>
        <img width="1296" height="622" alt="image" src="https://github.com/user-attachments/assets/e9736ddd-356f-44b5-bf13-a26dbaadebf6" />

</div>

## 📖 Overview

This project has evolved from a flat-file (`AccFile.txt`) prototype into a fully SQL Server–backed banking app. Every account now carries an **account number, account title, CNIC, and balance**, and the main account grid (`DisplayForm`) supports **dynamic, multi-field filtering** built entirely from parameterized SQL, no in-memory filtering, no static file I/O.

---

## ✨ Features

| Feature | Description |
|---|---|
| 🆕 **Create Account** | Account number (`PKBM<digits>` format), account title, CNIC, and starting balance |
| 💵 **Deposit** | Adds funds; requires account number (via dropdown), title, and CNIC as an identity check |
| 💸 **Withdrawal** | Deducts funds with the same identity check, blocked if insufficient funds |
| ✏️ **Edit Account** | Update balance, title, and CNIC for an account, opened directly from the grid row |
| 🗑️ **Delete Account** | Remove an account directly from the grid, with a Yes/No confirmation |
| 🔍 **Multi-Field Filtering** | Filter by Account Number, Account Title, CNIC, and a Balance range (From/To), any combination, dynamically built into one SQL query |
| ⌨️ **Enter-to-Search** | Pressing Enter in any filter box triggers the same search as clicking "Search" |
| 📊 **Live Dashboard Stats** | Main menu shows total account count and total bank balance on load |
| 🗂️ **Menu Bar Navigation** | Full `MenuStrip` (Accounts → Create/View All, Transactions → Deposit/Withdraw) alongside the original buttons |

---

## 🗂️ Project Structure

```
WinFormsBankingApp/
│
├── Program.cs                        # Application entry point
├── Form1.cs / .Designer.cs           # Main dashboard (live stats, menu bar, nav buttons)
├── CreateAccountForm.cs / .Designer.cs   # Create a new account (AccNum, Title, CNIC, Balance)
├── Deposit.cs / .Designer.cs         # Deposit form (dropdown + title/CNIC identity check)
├── Withdrawal.cs / .Designer.cs      # Withdrawal form (dropdown + title/CNIC identity check)
├── DisplayForm.cs / .Designer.cs     # Main grid: view, filter, edit, delete accounts
├── FormEditRecord.cs / .Designer.cs  # Edit an existing account's balance/title/CNIC
├── Account.cs                        # Account model (accountNumber, accountTitle, cnic, balance)
├── Banking.cs                        # Static SQL data-access layer (Create/Deposit/Withdrawal/Remove/Load)
└── DbHelper.cs                       # SQL Server connection string
```

---

## 🧩 Architecture

```
┌───────────────┐        uses         ┌──────────────────┐
│    Form1      │────────────────────▶│      Banking      │
│ (Dashboard)   │                     │ (static SQL logic) │
└───────┬───────┘                     └─────────┬──────────┘
        │ opens                                 │ reads/writes
        ▼                                        ▼
┌────────────────────────────┐          ┌───────────────┐
│ CreateAccountForm            │          │  tblAccounts   │
│ Deposit                      │          │ (SQL Server)   │
│ Withdrawal                   │          │ AccNum,        │
│ DisplayForm ──▶ FormEditRecord│         │ AccTitle,      │
│      (filters + grid)        │          │ Cnic, Balance  │
└────────────────────────────┘          └───────────────┘
```

### `Account` model

```csharp
public string accountNumber { get; set; }
public string accountTitle { get; set; }
public string cnic { get; set; }
public int balance { get; set; }
```

### `Banking` (static data-access layer)

- `Create(accNumber, accTitle, cnic, balance)`: inserts a new row, blocks negative balances and duplicate account numbers
- `Deposit(numb, title, cnic, bal)`: increases balance, **matched by AccNum + AccTitle + CNIC together**
- `Withdrawal(numb, title, cnic, amt)`: decreases balance if funds are sufficient, same identity match
- `Remove(accnumb)`: deletes by account number, with an existence check first
- `LoadAccountsIntoList(search)`: legacy single-field search (superseded by `DisplayForm.FilteredLoadIntoGrid` for multi-field filtering)

---

## 🔎 Filtering — how it works

`DisplayForm.FilteredLoadIntoGrid()` builds a SQL query **dynamically**, adding only the conditions the user actually filled in:

```csharp
var conditions = new List<string>();

if (rangeFrom != "" && rangeTo != "")
    conditions.Add("Balance BETWEEN @From AND @To");

if (accNum != "")
    conditions.Add("AccNum LIKE @accnum");

if (accTitle != "")
    conditions.Add("AccTitle LIKE @acctitle");

if (accCnic != "")
    conditions.Add("Cnic LIKE @acccnic");

queryFinal = conditions.Count == 0
    ? queryFirstHalf + ";"
    : queryFirstHalf + " WHERE " + string.Join(" AND ", conditions) + ";";
```

Each condition is paired with a parameter added only when that field was used, so the query never references a parameter that wasn't actually inserted into the SQL text, and vice versa. This is the core "dynamic string, safe parameters" pattern used throughout the app: **column/structure comes from trusted, hardcoded strings; user-typed values always go through `@parameters`, never string concatenation.**

### Filter fields available

| Field | Match type |
|---|---|
| Account Number | `LIKE '%value%'` (contains) |
| Account Title | `LIKE '%value%'` (contains) |
| CNIC | `LIKE '%value%'` (contains) |
| Balance | `BETWEEN @From AND @To` (only applied if **both** From and To are filled) |

### Enter-to-search

Every filter textbox (`textBoxAccNum`, `textBoxAccTitle`, `textBoxAccCnic`, `textBoxFromValue`, `textBoxToValue`) has a `KeyDown` handler that checks for `Keys.Enter` and calls `btnSearch_Click` directly, with `e.SuppressKeyPress = true` to prevent the system "ding" sound.

---

## 🚀 Getting Started

### Prerequisites
- Windows OS, .NET SDK (WinForms support)
- SQL Server instance (local, LocalDB, or named instance)
- `Microsoft.Data.SqlClient` NuGet package

### Database setup

```sql
CREATE TABLE tblAccounts (
    AccNum   VARCHAR(50) NOT NULL PRIMARY KEY,
    AccTitle VARCHAR(50) NULL,
    Cnic     VARCHAR(50) NULL,
    Balance  INT NOT NULL
);
```

### Connection string

Set in `DbHelper.cs`:

```csharp
public static string connectionString =
    "server=YOUR_SERVER\\INSTANCE;user id=YOUR_USER;password=YOUR_PASSWORD;database=YOUR_DB;TrustServerCertificate=True;";
```

> ⚠️ Keep real credentials out of source control, see the "Security Notes" section below.

---

## ⚠️ Known Issues

- 🧮 **`Deposit` collects identity fields but its `UPDATE` doesn't consistently verify them**: check current `Banking.Deposit`/`Banking.Withdrawal` to confirm both enforce `AccNum + AccTitle + Cnic` matching, and that a **row-count check** (`ExecuteNonQuery()`'s return value) is used to detect a failed identity match instead of assuming success.
- 🔢 **Balance range parameters mix types**: `command.Parameters.AddWithValue("@From", rangeFrom)` passes a raw **string** for a column that's `INT`; relies on SQL Server's implicit conversion rather than parsing with `Convert.ToInt32` first. Same for the `@To` default of `100000000` (an `int` literal), mixing string and int values across calls to the same parameter name is inconsistent and worth normalizing.
- 🖊️ **`FormEditRecord`'s balance parameter** is still passed as a raw string (`balanceStr`) rather than a parsed `int` in some versions, validate and convert before sending to SQL.
- 🧾 **Empty-field validation in `FormEditRecord`** for Account Title/CNIC shows a warning but may not always `return;` afterward, confirm both checks stop execution, not just display a message.
- 🔒 **Hardcoded connection string**: currently committed directly in `DbHelper.cs`; move to a git-ignored config file or environment variable before pushing to a public repo.
- 🪪 **No uniqueness enforcement on CNIC**: the same CNIC could currently be used across multiple account numbers, since only `AccNum` is checked for duplicates on creation.

---

## 🔐 Security Notes

- All user-supplied **values** are passed through `SqlParameter`/`AddWithValue`, never concatenated directly into SQL text. This is correct and should stay consistent across any new query added to the app.
- **Column names are never taken from user input**, they're always hardcoded strings chosen by the developer (e.g. `"AccNum LIKE @accnum"`), which is what keeps dynamic query-building safe from SQL injection. If a future feature (e.g. "pick which column to search") is added, any column name coming from a dropdown/user choice must be checked against a hardcoded whitelist before being inserted into the query string.
- Do not commit real database credentials to GitHub. Use `.gitignore` on a config file holding `DbHelper.connectionString`, or migrate to environment variables / `dotnet user-secrets`.

---

## 🛠️ Suggested Improvements

- [ ] Add a unique constraint or duplicate-check on `Cnic`, not just `AccNum`
- [ ] Normalize balance-range parameters to always pass parsed `int` values, never raw strings
- [ ] Add row-count checks (`ExecuteNonQuery()` return value) after every `UPDATE`/`DELETE` to detect silent no-op matches
- [ ] Move `DbHelper.connectionString` out of source control
- [ ] Consolidate `Banking.LoadAccountsIntoList(search)` and `DisplayForm.FilteredLoadIntoGrid()`, the former is now largely superseded by the latter's multi-field filtering
- [ ] Add client-side CNIC format validation (13 digits, optional dashes) before hitting the database

---

## 📜 License

This project is provided as-is for educational purposes. Add your preferred license here.

---

<div align="center">

**Built with ❤️ using C# WinForms + SQL Server**

</div>
