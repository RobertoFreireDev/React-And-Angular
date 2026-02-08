# Project Idea: "Personal Finance Manager" Web App

## Core Features:

### Dashboard Module

* Shows a summary of expenses, and budgets
* Use charts or graphs for visualization

### Expenses Module

* Forms: Add, edit, delete expenses
* Forms: Create/edit/delete budgets
* Validation: Ensure correct inputs (numbers, dates, categories)
* Set monthly budgets per category
* Create categories if new

### Notes:

* Lazy Loading all modules
* Global state for Categories

# The same application implemented in 2 frameworks:

* React
* Angular

# Angular → React 

| Angular Concept | React Equivalent | Example |
|-----------------|----------------|---------|
| **Component** | Function / Class Component | `function Hello() { return <h1>Hello</h1>; }` |
| **Attribute Directive** | JSX props / inline style / className | `[ngClass]="condition"` → `className={condition ? "classA" : "classB"}`<br>`[ngStyle]="{color: isRed ? 'red':'blue'}"` → `style={{ color: isRed ? 'red' : 'blue' }}` |
| **Event Binding** | JSX events | `(click)="handleClick()"` → `<button onClick={handleClick}>Click</button>` |
| **Two-way Binding** | Controlled component (state + onChange) | `[(ngModel)]="value"` → `<input value={value} onChange={e => setValue(e.target.value)} />` |

# Hooks

## React

* useState -> Manages local component state. form inputs
* useEffect -> Handles side effects. Data fetching
* useMemo -> Prevents unnecessary recalculations

## Angular

* ngOnInit -> Runs once after Angular sets input properties. API calls
* ngOnChanges -. Runs when @Input() values change. Useful for reacting to parent → child updates
* ngOnDestroy -> Runs just before the component is destroyed. unsubscribe

# Forms

## React

* Controlled components using useState
* Uncontrolled components using refs

## Angular

* Template-driven forms
* Reactive forms

# State Management

## React

* Redux

# Angular

* NgRx

# Modules

* Isolate parts of application in modules and lazy load modules