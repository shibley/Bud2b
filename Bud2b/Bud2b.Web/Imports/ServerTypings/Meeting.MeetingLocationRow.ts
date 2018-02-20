namespace Bud2b.Meeting {
    export interface MeetingLocationRow {
        LocationId?: number;
        Name?: string;
        Address?: string;
        Latitude?: number;
        Longitude?: number;
        TenantId?: number;
    }

    export namespace MeetingLocationRow {
        export const idProperty = 'LocationId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.MeetingLocation';
        export const lookupKey = 'Meeting.MeetingLocation';

        export function getLookup(): Q.Lookup<MeetingLocationRow> {
            return Q.getLookup<MeetingLocationRow>('Meeting.MeetingLocation');
        }

        export namespace Fields {
            export declare const LocationId: string;
            export declare const Name: string;
            export declare const Address: string;
            export declare const Latitude: string;
            export declare const Longitude: string;
            export declare const TenantId: string;
        }

        ['LocationId', 'Name', 'Address', 'Latitude', 'Longitude', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

