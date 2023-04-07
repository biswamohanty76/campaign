import { ProductDeleteComponent } from './components/product/product-delete/product-delete.component';
import { ProductUpdateComponent } from './components/product/product-update/product-update.component';
import { CandidateComponent } from './components/candidate/candidate.component';
import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { HomeComponent } from "./views/home/home.component";
import { ProductCrudComponent } from "./views/product-crud/product-crud.component";
import { ProductCreateComponent } from './components/product/product-create/product-create.component';
import { JobComponent } from './components/job/job.component';
import { ContestComponent } from './components/contest/contest.component';
import { UserComponent } from './components/user/user.component';


const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path:"candidates",
    component: CandidateComponent
  },
  {
    path:"jobs",
    component:JobComponent
  },
  {
    path:"contests",
    component:ContestComponent
  },
  {
    path:"users",
    component:UserComponent
  }
  // {
  //   path: "products",
  //   component: ProductCrudComponent
  // },
  // {
  //   path: "products/create",
  //   component: ProductCreateComponent
  // },
  // {
  //   path: "products/update/:id",
  //   component: ProductUpdateComponent
  // },
  // {
  //   path: "products/delete/:id",
  //   component: ProductDeleteComponent
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
