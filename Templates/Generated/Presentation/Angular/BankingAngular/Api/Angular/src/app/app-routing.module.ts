import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HeroFormComponent } from "./hero-form/hero-form.component";
import { BankAccountComponent } from "./bank-account/bank-account.component"
import { BooksComponent } from "./books/books.component"
import { CountriesComponent } from "./countries/countries.component"
import { CustomersComponent } from "./customers/customers.component"
import { SoftwareComponent } from "./software/software.component"
import { LoginComponent } from "./login/login.component"

const routes: Routes = [
  {
    path: "",
    component: HeroFormComponent

  },
  {
    path: "bankAccount",
    component: BankAccountComponent 
  },
  {
    path: "books",
    component: BooksComponent
  },
  {
    path: "countries",
    component: CountriesComponent 
  },
  {
    path: "customers",
    component: CustomersComponent 
  },
  {
    path: "software",
    component: SoftwareComponent
  },
  {
    path: "login",
    component: LoginComponent 
  },
  //{
  //  path: 'courses/:id',
  //  component: CourseComponent,
  //  resolve: {
  //    course: CourseResolver
  //  }
  //},
  {
    path: "**",
    redirectTo: '/'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
