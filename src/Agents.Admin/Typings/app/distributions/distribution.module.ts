import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { DistributionRoutingModule } from './distribution-routing.module';
import { CommissionListComponent } from './commission/commission-list.component';
import { CommissionCreateComponent } from './commission/commission-create.component';
import { CommissionEditComponent } from './commission/commission-edit.component';
import { CommissionDetailComponent } from './commission/commission-detail.component';
import { DomainListComponent } from './domain/domain-list.component';
import { DomainCreateComponent } from './domain/domain-create.component';
import { DomainEditComponent } from './domain/domain-edit.component';
import { DomainDetailComponent } from './domain/domain-detail.component';
import { DomainTypeListComponent } from './domain-type/domain-type-list.component';
import { DomainTypeCreateComponent } from './domain-type/domain-type-create.component';
import { DomainTypeEditComponent } from './domain-type/domain-type-edit.component';
import { DomainTypeDetailComponent } from './domain-type/domain-type-detail.component';

/**
 * distributions模块
 */
@NgModule({
    declarations: [
        CommissionListComponent,CommissionCreateComponent,CommissionEditComponent,CommissionDetailComponent,
        DomainListComponent,DomainCreateComponent,DomainEditComponent,DomainDetailComponent,
        DomainTypeListComponent,DomainTypeCreateComponent,DomainTypeEditComponent,DomainTypeDetailComponent,
    ],
    imports: [
        FrameworkModule,DistributionRoutingModule
    ]
})
export class DistributionModule {
}