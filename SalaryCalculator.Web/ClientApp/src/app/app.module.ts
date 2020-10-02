import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { EmployeeService } from './common/services/employee.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddSatisfactoryScoreComponent } from './add-satisfactory-score/add-satisfactory-score.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ErrorHandlingInterceptor } from './errorHandler.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    AddSatisfactoryScoreComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ModalModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
    ]),
    BrowserAnimationsModule
  ],
  providers: [EmployeeService, { provide: HTTP_INTERCEPTORS, useClass: ErrorHandlingInterceptor, multi: true }],
  bootstrap: [AppComponent]
})
export class AppModule { }
