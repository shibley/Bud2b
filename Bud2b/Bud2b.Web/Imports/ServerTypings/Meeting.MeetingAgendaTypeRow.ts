namespace Bud2b.Meeting {
    export interface MeetingAgendaTypeRow {
        AgendaTypeId?: number;
        Name?: string;
        TenantId?: number;
    }

    export namespace MeetingAgendaTypeRow {
        export const idProperty = 'AgendaTypeId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.MeetingAgendaType';
        export const lookupKey = 'Meeting.MeetingAgendaType';

        export function getLookup(): Q.Lookup<MeetingAgendaTypeRow> {
            return Q.getLookup<MeetingAgendaTypeRow>('Meeting.MeetingAgendaType');
        }

        export namespace Fields {
            export declare const AgendaTypeId: string;
            export declare const Name: string;
            export declare const TenantId: string;
        }

        ['AgendaTypeId', 'Name', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

