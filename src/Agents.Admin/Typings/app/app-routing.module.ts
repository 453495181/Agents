import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutDefaultComponent } from './home/layout/default/default.component';
import { DashboardV1Component } from './home/dashboard/v1.component';
import { LoginCallbackComponent } from "./login-callback.component";
import { OidcAuthorize as Authorize } from "../util";
//路由配置
const routes: Routes = [
    {
        path: '',
        component: LayoutDefaultComponent,
        canActivate: [Authorize],
        canActivateChild: [Authorize],
        children: [
            { path: '', redirectTo: 'dashboard/v1', pathMatch: 'full' },
            { path: 'dashboard', redirectTo: 'dashboard/v1', pathMatch: 'full' },
            { path: 'dashboard/v1', component: DashboardV1Component },
            //{ path: 'demo', loadChildren: "./demo/demo.module#DemoModule" },
            //{ path: 'component', loadChildren: "./components/component.module#ComponentModule" },
            { path: 'agents', loadChildren: "./agents/agent.module#AgentModule" },
            { path: 'members', loadChildren: "./members/member.module#MemberModule" },
            { path: 'sales', loadChildren: "./sales/sale.module#SaleModule" },
            { path: 'sales', loadChildren: "./sales/sale.module#SaleModule" },
            { path: 'distributions', loadChildren: "./distributions/distribution.module#DistributionModule" }
        ]
    },
    {
        path: 'callback',
        component: LoginCallbackComponent
    }
];

/**
 * 路由配置模块
 */
@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ]
})
export class AppRoutingModule { }