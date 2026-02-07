import { Routes } from "@angular/router";
import { DashboardComponent } from "./modules/dashboard/dashboard.component";
import { ExpensesComponent } from "./modules/expenses/expenses.component";

export const routes: Routes = [
  {
    path: "",
    component: DashboardComponent,
  },
  {
    path: "expenses",
    component: ExpensesComponent,
  },
];
