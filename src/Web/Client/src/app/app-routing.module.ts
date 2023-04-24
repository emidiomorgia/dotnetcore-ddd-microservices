import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConnectionDemoComponent } from './connection-demo/connection-demo.component';

const routes: Routes = [
  { path: 'connection-demo', component: ConnectionDemoComponent },
  { path: '',   redirectTo: '/connection-demo', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
