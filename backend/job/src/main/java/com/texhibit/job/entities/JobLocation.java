package com.texhibit.job.entities;

import lombok.Getter;

@Getter
public class JobLocation {
    private Address address;
    private Double latitude;
    private Double longitude;
}
