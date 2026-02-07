import { Component } from "@angular/core";

@Component({
  selector: "app-expenses",
  standalone: true,
  template: `
    <h1>Expenses</h1>
  `,
  styles: [
    `
      .expenses {
        padding: 24px;
      }
    `,
  ],
})
export class ExpensesComponent {}
