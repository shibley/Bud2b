﻿namespace Bud2b.Default {
    export interface TenantsRow {
        TenantId?: number;
        TenantName?: string;
    }

    export namespace TenantsRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'Default.Tenants';
        export const lookupKey = 'Administration.Tenant';

        export function getLookup(): Q.Lookup<TenantsRow> {
            return Q.getLookup<TenantsRow>('Administration.Tenant');
        }

        export namespace Fields {
            export declare const TenantId: string;
            export declare const TenantName: string;
        }

        ['TenantId', 'TenantName'].forEach(x => (<any>Fields)[x] = x);
    }
}

