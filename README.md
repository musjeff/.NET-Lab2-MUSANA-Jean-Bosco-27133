# .NET-Lab2-MUSANA-Jean-Bosco-27133
# Bicycle Rental & Mushroom Identifier

A Windows Forms application (C# / .NET 8) with a login screen, a menu, a **bicycle rental price calculator** and a **mushroom identifier**. It was built as a mini project for a C# lab on variables, operators, decision statements and loops.

- **Author:** _your name_
- **Student number:** _your student number_

## Features

| Form | What it does |
|---|---|
| **Login** | Accepts any username and password, but neither may be empty or whitespace-only. |
| **Menu** | Lets the user choose **Bicycle Rental** or **Mushroom Identifier**. |
| **Bicycle Rental** | Calculates the rental price from a start hour and an end hour. |
| **Mushroom Identifier** | Identifies one of six mushrooms by asking at most three yes/no questions. |

There is no database and nothing is saved between runs.

## Navigation

```
Login ──(Sign In)──► Menu ──(Open)──► Bicycle Rental
                      ▲   └─(Open)──► Mushroom Identifier
                      │                     │
                      └──────(Close)────────┘

Menu ──(Close)──► Login ──(Close)──► application exits
```

- **Login → Close** is the only button that exits the application.
- Every form has a **Close** button. The title-bar X is hidden on all forms, and Alt+F4 is blocked on the Login form.

## Requirements

- Windows 10 or 11
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community is free) with the **.NET desktop development** workload
- .NET 8 SDK (installed with that workload)

## How to run

**In Visual Studio**

1. Extract the zip. Visual Studio cannot open a project from inside a zip.
2. Double-click `BicycleMushroomApp.csproj`.
3. Press **F5**.

**From the command line**

```
cd BicycleMushroomApp
dotnet run
```

If you have an older .NET version, change `net8.0-windows` in `BicycleMushroomApp.csproj` to your version (for example `net6.0-windows`).

## Problem 1: Bicycle Rental

Enter the start hour and the end hour as whole numbers.

**Input rules**

- Whole numbers only (decimals are rejected)
- Start hour: 0 to 23
- End hour: 1 to 24
- Start must be less than end, so a rental never spans more than one day

**Rates per hour**

| Time of day | Rate |
|---|---|
| 0h – 7h and 21h – 24h | 500 RWF |
| 7h – 14h and 19h – 21h | 1,000 RWF |
| 14h – 19h | 1,500 RWF |

The program loops over each hour of the rental, adds the rate for that hour, and shows the total.

**Examples**

| Start | End | Total |
|---|---|---|
| 14 | 19 | 7,500 RWF |
| 6 | 15 | 9,000 RWF |
| 0 | 24 | 21,500 RWF |

## Problem 2: Mushroom Identifier

Think of one of the six mushrooms and answer yes or no. The program names it after at most three questions.

| Mushroom | Gills | Forest | Ring | Convex cup |
|---|---|---|---|---|
| Agaric jaunissant | yes | no | yes | yes |
| Amanite tue-mouche | yes | yes | yes | yes |
| Cepe de Bordeaux | no | yes | no | no |
| Coprin chevelu | yes | no | yes | no |
| Girolle | yes | yes | no | no |
| Pied bleu | yes | yes | no | yes |

**Decision tree used**

```
Grows in a forest?
├─ Yes → Convex cup?
│        ├─ Yes → Ring?  ├─ Yes → Amanite tue-mouche
│        │               └─ No  → Pied bleu
│        └─ No  → Gills? ├─ Yes → Girolle
│                        └─ No  → Cepe de Bordeaux
└─ No  → Convex cup?
         ├─ Yes → Agaric jaunissant
         └─ No  → Coprin chevelu
```

Use **Restart** to try another mushroom.

## Project structure

| File | Purpose |
|---|---|
| `Program.cs` | Entry point; starts the Login form |
| `LoginForm.cs` / `.Designer.cs` | Login validation and the exit button |
| `MenuForm.cs` / `.Designer.cs` | Menu and navigation |
| `BicycleRentalForm.cs` / `.Designer.cs` | Rental price calculation |
| `MushroomIdentifierForm.cs` / `.Designer.cs` | Question tree for the mushrooms |
| `Theme.cs` | Shared colours and button style |

Each form has a `.Designer.cs` file, so it opens in the Visual Studio Designer and you can edit the layout visually.

## Possible improvements

- Show the hourly breakdown of a rental
- Let the user pick the rental hours with dropdowns instead of typing
- Add more mushrooms to the decision tree
