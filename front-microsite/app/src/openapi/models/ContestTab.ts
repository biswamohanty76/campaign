/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Document on Azure Functions
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface ContestTab
 */
export interface ContestTab {
    /**
     * 
     * @type {number}
     * @memberof ContestTab
     */
    id?: number;
    /**
     * 
     * @type {string}
     * @memberof ContestTab
     */
    key?: string;
    /**
     * 
     * @type {string}
     * @memberof ContestTab
     */
    value?: string;
    /**
     * 
     * @type {number}
     * @memberof ContestTab
     */
    contestId?: number;
    /**
     * 
     * @type {number}
     * @memberof ContestTab
     */
    orderNumber?: number;
}

/**
 * Check if a given object implements the ContestTab interface.
 */
export function instanceOfContestTab(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function ContestTabFromJSON(json: any): ContestTab {
    return ContestTabFromJSONTyped(json, false);
}

export function ContestTabFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContestTab {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'key': !exists(json, 'key') ? undefined : json['key'],
        'value': !exists(json, 'value') ? undefined : json['value'],
        'contestId': !exists(json, 'contestId') ? undefined : json['contestId'],
        'orderNumber': !exists(json, 'orderNumber') ? undefined : json['orderNumber'],
    };
}

export function ContestTabToJSON(value?: ContestTab | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'key': value.key,
        'value': value.value,
        'contestId': value.contestId,
        'orderNumber': value.orderNumber,
    };
}

