import { Component } from "@angular/core";

@Component({
  selector: "app-dashboard",
  standalone: true,
  template: `
    <h1>Dashboard</h1>
  `,
  styles: [
    `
      .dashboard {
        padding: 24px;
      }
    `,
  ],
})
export class DashboardComponent {}
